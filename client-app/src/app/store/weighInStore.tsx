import { makeAutoObservable } from 'mobx';
import { WeighIn } from '../model/WeighIn';
import agent from '../api/agent';

export default class WeighInStore {
  weighIns = Array.of<WeighIn>();

  constructor() {
    makeAutoObservable(this);
  }

  async loadWeighIns() {
    this.weighIns = await agent.WeighIns.getAll();
  }
}
