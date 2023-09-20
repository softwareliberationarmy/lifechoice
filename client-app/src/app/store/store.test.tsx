import { describe, expect, it } from 'vitest';
import { Store, useStore } from './store';
import { render, waitFor } from '@testing-library/react';
import WeighInStore from './weighInStore';

interface Props {
  getStore: (store: Store) => void;
}

export const DummyComponent = ({ getStore }: Props) => {
  const store = useStore();
  getStore(store);
  return <div>Nothing.</div>;
};

describe('stateful mobx stores', () => {
  it('should return the same store instance', async () => {
    let store1: Store;
    let store2: Store;

    render(
      <DummyComponent
        getStore={(store) => {
          store1 = store;
        }}
      />
    );
    render(
      <DummyComponent
        getStore={(store) => {
          store2 = store;
        }}
      />
    );

    await waitFor(() => {
      expect(store1).toBe(store2);
    });
  });

  it('should have a weighInStore', async () => {
    let store1: WeighInStore;
    let store2: WeighInStore;

    render(
      <DummyComponent
        getStore={(store) => {
          store1 = store.weighInStore;
        }}
      />
    );
    render(
      <DummyComponent
        getStore={(store) => {
          store2 = store.weighInStore;
        }}
      />
    );

    await waitFor(() => {
      expect(store1).toBe(store2);
    });
  });
});
