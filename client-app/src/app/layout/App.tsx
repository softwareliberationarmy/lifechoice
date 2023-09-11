import { useEffect, useState } from 'react';
import axios from 'axios';
import { NavBar } from './NavBar';
import { WeighInList } from '../../features/weigh-ins/WeighInList';
import { Container } from 'semantic-ui-react';

function App() {
  const [weighIns, setWeighIns] = useState([]);

  useEffect(() => {
    axios
      .get('http://localhost:5001/api/weighin')
      .then((response) => setWeighIns(response.data));
  }, []);

  return (
    <>
      <NavBar onCreateNew={() => {}} />
      <Container style={{ marginTop: '7em' }}>
        <WeighInList weighIns={weighIns} />
      </Container>
    </>
  );
}

export default App;
