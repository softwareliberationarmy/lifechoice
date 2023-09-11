import { List, ListItem } from 'semantic-ui-react';
import { WeighIn } from '../../app/model/WeighIn';

interface Props {
  weighIns: WeighIn[];
}

export const WeighInList = ({ weighIns }: Props) => {
  return (
    <List>
      {weighIns.map((wi: WeighIn) => (
        <ListItem key={wi.id}>
          {wi.date} - {wi.weight} lbs
        </ListItem>
      ))}
    </List>
  );
};
