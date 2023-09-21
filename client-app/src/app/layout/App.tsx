import { useEffect, useState } from 'react';
import { NavBar } from './NavBar';
import { WeighInList } from '../../features/weigh-ins/WeighInList';
import { Container } from 'semantic-ui-react';
import { WeighIn } from '../model/WeighIn';
import { WeighInModal } from '../../features/weigh-ins/WeighInModal';
import { useStore } from '../store/store';

function App() {

  const { weighInStore } = useStore();
  const [showModal, setShowModal] = useState(false);

  function requestNewWeighIn() {
    setShowModal(true);
  }

  function cancelNewWeighIn() {
    setShowModal(false);
  }

  function createNewWeighIn(wi: WeighIn) {
    weighInStore.addWeighIn(wi);
    setShowModal(false);
  }

  useEffect(() => {
    weighInStore.loadWeighIns();
  }, []);

  return (
    <>
      <WeighInModal
        open={showModal}
        onCancel={cancelNewWeighIn}
        onSubmit={createNewWeighIn}
      />
      <NavBar onCreateNew={requestNewWeighIn} />
      <Container style={{ marginTop: '7em' }}>
        <WeighInList />
      </Container>
    </>
  );
}

export default App;
