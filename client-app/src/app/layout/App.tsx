import { useEffect, useState } from 'react';
import { NavBar } from './NavBar';
import { WeighInList } from '../../features/weigh-ins/WeighInList';
import { Container } from 'semantic-ui-react';
import { WeighIn } from '../model/WeighIn';
import { WeighInModal } from '../../features/weigh-ins/WeighInModal';
import agent from '../api/agent';

function App() {
  const [weighIns, setWeighIns] = useState<WeighIn[]>([]);
  const [showModal, setShowModal] = useState(false);

  function requestNewWeighIn() {
    setShowModal(true);
  }

  function cancelNewWeighIn() {
    setShowModal(false);
  }

  function createNewWeighIn(wi: WeighIn) {
    setWeighIns([...weighIns, wi]);
    setShowModal(false);
  }

  useEffect(() => {
    agent.WeighIns.getAll().then((weighIns) => setWeighIns(weighIns));
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
        <WeighInList weighIns={weighIns} />
      </Container>
    </>
  );
}

export default App;
