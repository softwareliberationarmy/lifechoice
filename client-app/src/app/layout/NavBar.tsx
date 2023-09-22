import { Button, Menu } from 'semantic-ui-react';
import { useStore } from '../store/store';
import { observer } from 'mobx-react-lite';

export const NavBar = observer(() => {
  const { weighInStore } = useStore();
  const { setCreateMode } = weighInStore;

  return (
    <Menu inverted as="nav" fixed="top">
      <Menu.Item
        as="h2"
        icon="heartbeat"
        content="Life Choice"
        header
      ></Menu.Item>
      <Menu.Item>
        <Button
          positive
          content="Create Weigh In"
          onClick={() => setCreateMode(true)}
        />
      </Menu.Item>
    </Menu>
  );
});
