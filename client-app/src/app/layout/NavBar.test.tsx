import { render, screen } from '@testing-library/react';
import { describe, it, expect, vi, beforeEach } from 'vitest';
import { NavBar } from './NavBar';
import { Store, useStore as storeHook } from '../store/store';

const useStore = storeHook as ReturnType<typeof vi.fn>;
vi.mock('../store/store');

const newWeighInStore = () => {
  const store: Store = {
    weighInStore: {
      weighIns: [],
      loadWeighIns: vi.fn(),
      addWeighIn: vi.fn(),
      createMode: false,
      setCreateMode: vi.fn(),
    },
  };
  return store;
};

describe('navigation bar', () => {
  let store: Store;
  beforeEach(() => {
    store = newWeighInStore();
    useStore.mockReturnValue(store);
  });

  describe('when I render the NavBar', () => {
    it('has a navigation role', () => {
      render(<NavBar />);
      expect(screen.getByRole('navigation')).toBeInTheDocument();
    });

    it('displays the Life Choice app name', () => {
      render(<NavBar />);
      expect(screen.getByText('Life Choice')).toBeInTheDocument();
    });

    it('shows a Create Weigh In button', () => {
      render(<NavBar />);
      expect(screen.getByRole('button')).toHaveTextContent('Create Weigh In');
    });
  });

  describe('when I click the Create Weigh In button', () => {
    it('handles the click event for the Create Weigh In button', () => {
      render(<NavBar />);

      screen.getByRole('button').click();

      expect(store.weighInStore.setCreateMode).toHaveBeenCalledOnce();
    });
  });
});
