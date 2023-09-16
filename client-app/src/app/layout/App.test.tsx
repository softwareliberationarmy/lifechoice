import { render, screen, waitFor } from '@testing-library/react';
import App from './App';
import { describe, it, expect, vitest, beforeEach } from 'vitest';
import agent from '../api/agent';
import userEvent from '@testing-library/user-event';
import { WeighIn } from '../model/WeighIn';

vitest.mock('../api/agent');

const mockWeighIns: WeighIn[] = [
  {
    id: 1,
    date: '2023-05-01',
    weight: 223.6,
    bmi: 1,
    bodyAge: 1,
    bodyFatPercent: 1,
    musclePercent: 1,
    restingMetabolismCalories: 1,
    visceralFat: 1,
  },
];

describe('the App component', () => {
  beforeEach(() => {
    vitest.mocked(agent.WeighIns.getAll).mockResolvedValue(mockWeighIns);

    render(<App />);
  });

  describe('when I render it', () => {
    it('renders header successfully', () => {
      expect(screen.getByText('Life Choice')).toBeInTheDocument();
    });

    it('shows the list of recent weigh-ins successfully', async () => {
      expect(screen.getByTestId('weigh-ins')).toBeInTheDocument();
      await waitFor(() => {
        expect(screen.getByText(mockWeighIns[0].date)).toBeInTheDocument();
      });
    });

    it('shows a nav bar', () => {
      expect(screen.getByRole('navigation')).toBeInTheDocument();
    });
  });

  describe('when I click the Create Weigh In button', () => {
    it('shows a new weigh in form when I click the Create Weigh In button', async () => {
      expect(screen.queryByText('New Weigh In')).not.toBeInTheDocument();

      const user = userEvent.setup();
      await user.click(screen.getByText('Create Weigh In'));

      expect(screen.getByText('New Weigh In')).toBeInTheDocument();
    });

    it('lets me cancel creating a new weigh in', async () => {
      const user = userEvent.setup();
      await user.click(screen.getByText('Create Weigh In'));

      expect(screen.getByText('New Weigh In')).toBeInTheDocument();

      await user.click(screen.getByText('Cancel'));

      expect(screen.queryByText('New Weigh In')).not.toBeInTheDocument();
      expect(screen.getAllByTestId('weigh-in')).toHaveLength(1);
    });

    it('lets me submit a new weigh in', async () => {
      const user = userEvent.setup();
      await user.click(screen.getByText('Create Weigh In'));
      expect(screen.getByText('New Weigh In')).toBeInTheDocument();

      await user.click(screen.getByPlaceholderText<HTMLInputElement>('Weight'));
      await user.keyboard('200.1');

      await user.click(screen.getByText('Submit'));

      expect(screen.queryByText('New Weigh In')).not.toBeInTheDocument();
      expect(screen.getAllByTestId('weigh-in')).toHaveLength(2);
    });
  });
});
