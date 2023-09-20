import { createContext, useContext } from 'react';
import WeighInStore from './weighInStore';

export interface Store {
  weighInStore: WeighInStore;
}

export const store: Store = {
  weighInStore: new WeighInStore(),
};

export const StoreContext = createContext(store);

export function useStore() {
  return useContext(StoreContext);
}
