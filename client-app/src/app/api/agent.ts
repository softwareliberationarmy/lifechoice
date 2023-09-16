import axios, { AxiosResponse } from 'axios';
import { WeighIn } from '../model/WeighIn';

axios.defaults.baseURL = 'http://localhost:5001/api';

const responseBody = <T>(response: AxiosResponse<T>) => response.data;

const api = {
  get: <T>(url: string) => axios.get<T>(url).then(responseBody),
  post: <T>(url: string, body: T) =>
    axios.post<T>(url, body).then(responseBody),
};

const WeighIns = {
  getAll: () => api.get<WeighIn[]>('/weighin'),
  getById: (id: number) => api.get<WeighIn>(`/weighin/${id}`),
  create: (weighIn: WeighIn) => api.post<WeighIn>('/weighin', weighIn),
};

const agent = {
  WeighIns,
};

export default agent;
