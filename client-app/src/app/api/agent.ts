import axios from 'axios';
import { WeighIn } from '../model/WeighIn';

const api = {
  get: <T>(url: string) => axios.get<T>(url).then((response) => response.data),
  post: <T>(url: string, body: T) =>
    axios.post<T>(url, body).then((response) => response.data),
};

const WeighIns = {
  getAll: () => api.get<WeighIn[]>('http://localhost:5001/api/weighin'),
  getById: (id: number) =>
    api.get<WeighIn>(`http://localhost:5001/api/weighin/${id}`),
  create: (weighIn: WeighIn) =>
    api.post<WeighIn>('http://localhost:5001/api/weighin', weighIn),
};

const agent = {
  WeighIns,
};

export default agent;
