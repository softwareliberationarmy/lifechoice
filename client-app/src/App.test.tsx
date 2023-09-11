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

    expect(screen.getByRole('list')).toBeInTheDocument();
    await waitFor(() => {
      expect(screen.getByRole('listitem')).toHaveTextContent(
        '2023-05-01 - 223.6 lbs'
      );
    });
  });

  it('shows a nav bar', () => {
    render(<App />);

    expect(screen.getByRole('navigation')).toBeInTheDocument();
  });
});
