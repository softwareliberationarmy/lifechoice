import { render, screen } from '@testing-library/react';
import App from './App';
import { describe, it, expect } from 'vitest';

describe('when I render the App component', () => {
  it('renders header successfully', () => {
    render(<App />);

    expect(screen.queryByText('Life Choice')).toBeInTheDocument();
  });
});
