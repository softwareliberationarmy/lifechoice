import { makeAutoObservable } from 'mobx';
import { WeighIn } from '../model/WeighIn';
import agent from '../api/agent';

export default class WeighInStore {
  weighIns = Array.of<WeighIn>();

  constructor() {
    makeAutoObservable(this);
  }

  loadWeighIns = async () => {
    this.weighIns = await agent.WeighIns.getAll();
  };

  addWeighIn = async (wi: WeighIn) => {
    await agent.WeighIns.create(wi);
    this.loadWeighIns();
  };
}
