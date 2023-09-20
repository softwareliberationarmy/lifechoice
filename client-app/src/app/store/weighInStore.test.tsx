import { makeAutoObservable } from 'mobx';
import { describe, expect, it, vi } from 'vitest';
import WeighInStore from './weighInStore';
import { waitFor } from '@testing-library/react';
import { WeighIn } from '../model/WeighIn';
import agent from '../api/agent';

vi.mock('mobx');
vi.mock('../api/agent');

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

  it('exposes a set of weigh-ins', () => {
    const store = new WeighInStore();
    expect(store.weighIns).toEqual(Array.of<WeighIn>());
  });

  it('loads the weigh-ins from the server', async () => {
    const expected = { id: 1, date: '2023-05-01', weight: 223.6 } as WeighIn;
    vi.mocked(agent.WeighIns.getAll).mockResolvedValue([expected]);

    const store = new WeighInStore();
    await store.loadWeighIns();

    expect(store.weighIns[0]).toBe(expected);
  });
});
