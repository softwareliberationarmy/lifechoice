import { Button, Header, Menu } from 'semantic-ui-react';

interface Props {
  onCreateNew: () => void;
}

export const NavBar = ({ onCreateNew }: Props) => {
  return (
    <Menu inverted as="nav">
      <Menu.Item
        as="h2"
        icon="heartbeat"
        content="Life Choice"
        header
      ></Menu.Item>
      <Menu.Item>
        <Button positive content="Create Weigh In" onClick={onCreateNew} />
      </Menu.Item>
    </Menu>
  );
};
