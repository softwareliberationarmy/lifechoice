import { render, screen } from '@testing-library/react';
import { describe, expect, it } from 'vitest';
import { WeighInList } from './WeighInList';
import { WeighIn } from '../../app/model/WeighIn';

describe('when I render the weigh in list', () => {
  it('shows the weigh-ins passed in', () => {
    render(
      <WeighInList
        weighIns={[{ id: 1, date: '2023-05-01', weight: 223.6 } as WeighIn]}
      />
    );

    const weighIns = screen.getAllByRole('listitem');

    expect(weighIns.length).toBe(1);
    expect(weighIns[0]).toHaveTextContent('2023-05-01 - 223.6 lbs');
  });
});
