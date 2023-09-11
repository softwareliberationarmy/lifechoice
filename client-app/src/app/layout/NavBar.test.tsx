import { render, screen } from '@testing-library/react';
import { describe, it, expect, vi } from 'vitest';
import { NavBar } from './NavBar';

describe('when I render the NavBar', () => {
  it('has a navigation role', () => {
    render(<NavBar />);
    expect(screen.getByRole('navigation')).toBeInTheDocument();
  });

  it('displays the Life Choice app name', () => {
    render(<NavBar />);
    expect(screen.getByText('Life Choice')).toBeInTheDocument();
  });

  it('shows a Create Weigh In button', () => {
    render(<NavBar />);
    expect(screen.getByRole('button')).toHaveTextContent('Create Weigh In');
  });

  it('handles the click event for the Create Weigh In button', () => {
    const mockOnClick = vi.fn();
    render(<NavBar onCreateNew={mockOnClick} />);

    screen.getByRole('button').click();

    expect(mockOnClick).toHaveBeenCalledOnce();
  });
});
