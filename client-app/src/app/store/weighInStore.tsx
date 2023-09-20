import { makeAutoObservable } from 'mobx';

export default class WeighInStore {
  constructor() {
    makeAutoObservable(this);
  }
}
