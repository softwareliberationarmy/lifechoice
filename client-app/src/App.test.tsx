import { render, screen, waitFor } from '@testing-library/react';
import App from './App';
import { describe, it, expect, vitest, beforeEach } from 'vitest';
import axios from 'axios';

vitest.mock('axios');

describe('when I render the App component', () => {
  beforeEach(() => {
    vitest.mocked(axios.get).mockResolvedValue({
      data: [
        {
          id: 1,
          date: '2023-05-01',
          weight: 223.6,
          bmi: 33.0,
          bodyFatPercent: 30.9,
          musclePercent: 32.3,
          restingMetabolismCalories: 2019,
          bodyAge: 69,
          visceralFat: 16,
        },
      ],
    });
  });

  it('renders header successfully', () => {
    render(<App />);

    expect(screen.getByText('Life Choice')).toBeInTheDocument();
  });

  it('shows the list of recent weigh-ins successfully', async () => {
    render(<App />);
    screen.debug();
    expect(screen.getByRole('list')).toBeInTheDocument();
    await waitFor(() => {
        expect(screen.getByRole('listitem')).toHaveTextContent('2023-05-01 - 223.6 lbs');
    });
  });
});
