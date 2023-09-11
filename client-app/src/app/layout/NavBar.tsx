import { Button, Menu } from 'semantic-ui-react';

interface Props {
    onCreateNew: () => void;
}

export const NavBar = ({ onCreateNew }: Props) => {
  return (
    <Menu as="nav">
      <Menu.Item header>Life Choice</Menu.Item>
      <Menu.Item>
        <Button positive content="Create Weigh In" onClick={onCreateNew} />
      </Menu.Item>
    </Menu>
  );
};
