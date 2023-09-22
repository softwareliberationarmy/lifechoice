import { useEffect } from 'react';
import { observer } from 'mobx-react-lite';
import { Container } from 'semantic-ui-react';

import { NavBar } from './NavBar';
import { WeighInList } from '../../features/weigh-ins/WeighInList';
import WeighInModal from '../../features/weigh-ins/WeighInModal';
import { useStore } from '../store/store';

function App() {
  const { weighInStore } = useStore();

  useEffect(() => {
    weighInStore.loadWeighIns();
  }, [weighInStore]);

  return (
    <>
      <WeighInModal />
      <NavBar />
      <Container style={{ marginTop: '7em' }}>
        <WeighInList />
      </Container>
    </>
  );
}

export default observer(App);
