import { Header, List, ListItem } from 'semantic-ui-react';
import { useEffect, useState } from 'react';
import axios from 'axios';
import { WeighIn } from './app/model/WeighIn';

function App() {
  const [weighIns, setWeighIns] = useState([]);

  useEffect(() => {
    axios
      .get('http://localhost:5001/api/weighin')
      .then((response) => setWeighIns(response.data));
  }, []);

  return (
    <>
      <Header as="h2" icon="heartbeat" content="Life Choice" />
      <List>
        {weighIns.map((wi: WeighIn) => (
          <ListItem key={wi.id}>
            {wi.date} - {wi.weight} lbs
          </ListItem>
        ))}
      </List>
    </>
  );
}

export default App;
