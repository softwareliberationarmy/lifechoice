import { describe, expect, it, vi } from 'vitest';
import { WeighIn } from '../model/WeighIn';
import axios, { AxiosResponse } from 'axios';
import agent from './agent.ts';

vi.mock('axios');

describe('api communication', () => {
  describe('configuration', () => {
    it('sets the base url for axios', () => {
      expect(axios.defaults.baseURL).toBe('http://localhost:5001/api');
    });
  });

  describe('weigh-ins', () => {
    const expected: WeighIn = {
      id: 1,
      date: '2023-09-16',
      weight: 100,
      bmi: 1,
      bodyFatPercent: 1,
      musclePercent: 1,
      restingMetabolismCalories: 1,
      bodyAge: 1,
      visceralFat: 1,
    };

    it('returns the weigh-ins from axios', async () => {
      vi.mocked(axios.get<WeighIn[]>).mockResolvedValue({
        data: Array.of<WeighIn>(expected),
      } as AxiosResponse<WeighIn[]>);

      const result = await agent.WeighIns.getAll();

      expect(result[0]).toEqual(expected);
      expect(axios.get).toHaveBeenCalledWith('/weighin');
    });

    it('returns a single weigh in by ID', async () => {
      vi.mocked(axios.get<WeighIn>).mockResolvedValue({
        data: expected,
      } as AxiosResponse<WeighIn>);

      const result = await agent.WeighIns.getById(expected.id);

      expect(result).toEqual(expected);
      expect(axios.get).toHaveBeenCalledWith(`/weighin/${expected.id}`);
    });

    it('creates a new weigh in', async () => {
      const expectedResponseData: WeighIn = { ...expected };
      const expectedResponse = {
        data: expectedResponseData,
      } as AxiosResponse<WeighIn>;
      vi.mocked(axios.post<WeighIn>).mockResolvedValue(expectedResponse);

      const result = await agent.WeighIns.create(expected);

      expect(axios.post).toHaveBeenCalledWith('/weighin', expected);
      expect(result).toBe(expectedResponseData);
    });
  });
});
