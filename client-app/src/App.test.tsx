import { render, screen } from '@testing-library/react';
import App from './App';
import { describe, it, expect } from 'vitest';

describe('when I render the App component', () => {
  it('renders header successfully', () => {
    render(<App />);

    expect(screen.getByText('Life Choice')).toBeInTheDocument();
  });

  it('shows the list of recent weigh-ins successfully', () => {
    render(<App />);

    expect(screen.getByRole('list')).toBeInTheDocument();
  });
});
