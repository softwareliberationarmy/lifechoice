import { Header, List, ListItem } from 'semantic-ui-react'
import './App.css'
import { useEffect, useState } from 'react';
import axios from 'axios';

function App() {

  const [weighIns, setWeighIns] = useState([]) ;

  useEffect(() => {
    axios.get('http://localhost:5050/api/weighin')
    .then(response => setWeighIns(response.data));
  }, []);

  return (
    <div>
    <Header as='h2' icon='heartbeat' content='Life Choice' />
    <List>
      { weighIns.map((wi: any) => (
        <ListItem key={wi.id}>
          {wi.date} - {wi.weight} lbs
        </ListItem>
      ))}
    </List>
    </div>
  )
}

export default App
