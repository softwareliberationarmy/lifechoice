import { render, screen } from '@testing-library/react';
import { beforeEach, describe, expect, it, vi } from 'vitest';
import { WeighInList } from './WeighInList';
import { WeighIn } from '../../app/model/WeighIn';

const givenWeighIns: WeighIn[] = [];

vi.mock('../../app/store/store', () => {
  return {
    useStore: () => ({
      weighInStore: {
        weighIns: givenWeighIns,
      },
    }),
  };
});

describe('when I render the weigh in list', () => {
  beforeEach(() => {
    givenWeighIns.length = 0;
  });

  const givenTheseWeighIns = (weighIns: WeighIn[]) => {
    givenWeighIns.push(...weighIns);
  };

  const whenIRenderAWeighInList = () => {
    render(<WeighInList />);
  };

  it('shows the weigh-ins passed in', () => {
    const expectedWeighIns = [
      {
        id: 1,
        date: '2023-05-01',
        weight: 223.6,
        bmi: 30,
        bodyFatPercent: 25,
        musclePercent: 35,
        restingMetabolismCalories: 1921,
        bodyAge: 62,
        visceralFat: 14,
      },
    ];

    givenTheseWeighIns(expectedWeighIns);
    whenIRenderAWeighInList();

    const expectedMetrics = [
      { key: 'pounds', value: '223.6' },
      { key: 'BMI', value: '30' },
      { key: '% body fat', value: '25' },
      { key: '% muscle', value: '35' },
      { key: 'resting metab', value: '1921' },
      { key: 'body age', value: '62' },
      { key: 'visceral fat', value: '14' },
    ];

    const weighIns = screen.getAllByTestId('weigh-in');

    expect(weighIns.length).toBe(1);
    expect(weighIns[0]).toHaveTextContent('2023-05-01');

    const metrics = screen.getAllByTestId('metric');
    expect(metrics.length).toBe(7);

    for (let i = 0; i < expectedMetrics.length; i++) {
      expect(metrics[i].children[0]).toHaveTextContent(
        expectedMetrics[i].value
      );
      expect(metrics[i].children[1]).toHaveTextContent(expectedMetrics[i].key);
    }
  });

  it('shows the most recent weigh-in at the top', () => {
    const threeUnorderedWeighIns = [
      {
        id: 1,
        date: '2023-05-23',
        weight: 223.6,
        bmi: 30,
        bodyFatPercent: 25,
        musclePercent: 35,
        restingMetabolismCalories: 1921,
        bodyAge: 62,
        visceralFat: 14,
      },
      {
        id: 2,
        date: '2023-06-01',
        weight: 223.6,
        bmi: 30,
        bodyFatPercent: 25,
        musclePercent: 35,
        restingMetabolismCalories: 1921,
        bodyAge: 62,
        visceralFat: 14,
      },
      {
        id: 3,
        date: '2024-01-01',
        weight: 223.6,
        bmi: 30,
        bodyFatPercent: 25,
        musclePercent: 35,
        restingMetabolismCalories: 1921,
        bodyAge: 62,
        visceralFat: 14,
      },
    ];

    givenTheseWeighIns(threeUnorderedWeighIns);
    whenIRenderAWeighInList();
    const weighIns = screen.getAllByTestId('weigh-in');

    expect(weighIns.length).toBe(3);
    expect(weighIns[0]).toHaveTextContent('2024-01-01');
  });
});
