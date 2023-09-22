import { useEffect } from 'react';
import { NavBar } from './NavBar';
import { WeighInList } from '../../features/weigh-ins/WeighInList';
import { Container } from 'semantic-ui-react';
import { WeighIn } from '../model/WeighIn';
import WeighInModal from '../../features/weigh-ins/WeighInModal';
import { useStore } from '../store/store';
import { observer } from 'mobx-react-lite';

function App() {
  const { weighInStore } = useStore();

  function cancelNewWeighIn() {
    weighInStore.setCreateMode(false);
  }

  function createNewWeighIn(wi: WeighIn) {
    weighInStore.addWeighIn(wi);
  }

  useEffect(() => {
    weighInStore.loadWeighIns();
  }, [weighInStore]);

  return (
    <>
      <WeighInModal onCancel={cancelNewWeighIn} onSubmit={createNewWeighIn} />
      <NavBar />
      <Container style={{ marginTop: '7em' }}>
        <WeighInList />
      </Container>
    </>
  );
}

export default observer(App);
