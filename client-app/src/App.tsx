import { List, ListItem } from 'semantic-ui-react';
import { useEffect, useState } from 'react';
import axios from 'axios';
import { WeighIn } from './app/model/WeighIn';
import { NavBar } from './app/layout/NavBar';

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
