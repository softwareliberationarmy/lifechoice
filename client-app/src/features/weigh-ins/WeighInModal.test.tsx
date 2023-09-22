import { beforeEach, describe, expect, it, vi } from 'vitest';
import { render, screen, waitFor } from '@testing-library/react';
import WeighInModal from './WeighInModal';
import { WeighIn } from '../../app/model/WeighIn';
import userEvent from '@testing-library/user-event';
import { Store, useStore as storeHook } from '../../app/store/store';

const useStore = storeHook as ReturnType<typeof vi.fn>;
vi.mock('../../app/store/store');

interface ModalTestInputs {
  shouldOpen?: boolean;
}

const stubWeighInStore = (initialState: boolean) => {
  const store: Store = {
    weighInStore: {
      createMode: initialState,
      weighIns: [],
      setCreateMode: vi.fn(),
      addWeighIn: vi.fn(),
      loadWeighIns: vi.fn(),
    },
  };

  return store;
};

const whenIRenderTheWeighInModal = ({ shouldOpen }: ModalTestInputs) => {
  const store = stubWeighInStore(shouldOpen ?? true);
  useStore.mockReturnValue(store);

  render(<WeighInModal />);

  return store;
};

describe('WeighInModal: modal for creating a new weigh-in', () => {
  describe('when weigh-in modal is created', () => {
    it('should be closed by default', () => {
      whenIRenderTheWeighInModal({ shouldOpen: false });

      expect(screen.queryByTestId('weigh-in-modal')).not.toBeInTheDocument();
    });
  });

  describe('when weigh-in modal is set as open', () => {
    beforeEach(() => {
      whenIRenderTheWeighInModal({});
    });

    it('should show up', () => {
      expect(screen.getByTestId('weigh-in-modal')).toBeInTheDocument();
    });

    it('should show header', () => {
      expect(screen.getByText('New Weigh In')).toBeInTheDocument();
    });

    it('should show form for capturing weigh in', () => {
      const formFields = [
        'Date',
        'Weight',
        'BMI',
        'BodyFat',
        'Muscle',
        'RestingMetab',
        'BodyAge',
        'VisceralFat',
      ];

      for (const field of formFields) {
        expect(screen.getByPlaceholderText(field)).toBeInTheDocument();
      }
    });

    it('should show cancel button', () => {
      //expect element with text 'Cancel' to be a button
      expect(
        screen.getByText('Cancel', { selector: 'button' })
      ).toBeInTheDocument();
    });

    it('should show submit button', () => {
      //expect element with text 'Cancel' to be a button
      expect(
        screen.getByText('Submit', { selector: 'button' })
      ).toBeInTheDocument();
    });
  });

  describe('when weigh-in modal is set as open with actions', () => {
    it('should set create mode when cancel button clicked', async () => {
      const store = whenIRenderTheWeighInModal({});

      await waitFor(() => {
        screen.getByText('Cancel').click();
      });

      expect(store.weighInStore.setCreateMode).toHaveBeenCalledWith(false);
    });

    it('should add the weigh in when submit button clicked', async () => {
      const store = whenIRenderTheWeighInModal({});

      await waitFor(() => {
        screen.getByText('Submit').click();
      });

      expect(store.weighInStore.addWeighIn).toHaveBeenCalledOnce();
    });
  });

  describe('when user updates values in weigh-in modal form', () => {
    let weighIn: WeighIn;

    beforeEach(() => {
      const submitAction = (wi: WeighIn) =>
        new Promise<void>(() => {
          weighIn = wi;
        });
      const store = whenIRenderTheWeighInModal({});
      store.weighInStore.addWeighIn = submitAction;
    });

    async function expectInputValueChangeToUpdateWeighIn(
      placeHolder: string,
      newValue: string,
      getWeighInValue: () => number
    ) {
      const user = userEvent.setup();

      //find the input value for weight and type in a new value
      await user.click(
        screen.getByPlaceholderText<HTMLInputElement>(placeHolder)
      );
      await user.keyboard(newValue);

      await user.click(screen.getByText('Submit'));

      //expect the weighIn object to have the new value
      expect(getWeighInValue()).toBe(+newValue);
    }

    it('should update the weight value', async () => {
      await expectInputValueChangeToUpdateWeighIn(
        'Weight',
        '201.2',
        () => weighIn.weight
      );
    });

    it('should update the bmi value', async () => {
      await expectInputValueChangeToUpdateWeighIn(
        'BMI',
        '30.1',
        () => weighIn.bmi
      );
    });

    it('should update the body fat value', async () => {
      await expectInputValueChangeToUpdateWeighIn(
        'BodyFat',
        '25.3',
        () => weighIn.bodyFatPercent
      );
    });

    it('should update the muscle value', async () => {
      await expectInputValueChangeToUpdateWeighIn(
        'Muscle',
        '35.3',
        () => weighIn.musclePercent
      );
    });

    it('should update the resting metabolism value', async () => {
      await expectInputValueChangeToUpdateWeighIn(
        'RestingMetab',
        '1921',
        () => weighIn.restingMetabolismCalories
      );
    });

    it('should update the body age value', async () => {
      await expectInputValueChangeToUpdateWeighIn(
        'BodyAge',
        '62',
        () => weighIn.bodyAge
      );
    });

    it('should update the visceral fat value', async () => {
      await expectInputValueChangeToUpdateWeighIn(
        'VisceralFat',
        '14',
        () => weighIn.visceralFat
      );
    });

    it('should update the date value', async () => {
      const user = userEvent.setup();

      //find the input value for weight and type in a new value
      await user.click(screen.getByPlaceholderText<HTMLInputElement>('Date'));
      await user.keyboard('2021-01-01');

      await user.click(screen.getByText('Submit'));

      //expect the weighIn object to have the new value
      expect(weighIn.date).toBe('2021-01-01');
    });
  });
});
