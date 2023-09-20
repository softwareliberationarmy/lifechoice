import { makeAutoObservable } from 'mobx';
import { describe, expect, it, vi } from 'vitest';
import WeighInStore from './weighInStore';
import { waitFor } from '@testing-library/react';

vi.mock('mobx');

describe('weigh in Mobx store', () => {
  it('auto observes', async () => {
    let actualStore: WeighInStore;
    vi.mocked(makeAutoObservable<WeighInStore>).mockImplementation((store) => {
      actualStore = store;
      return store;
    });
    const store = new WeighInStore();
    await waitFor(() => {
      expect(actualStore).toBe(store);
    });
  });
});
