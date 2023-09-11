import { Item, Segment, Statistic } from 'semantic-ui-react';
import { WeighIn } from '../../app/model/WeighIn';

interface Props {
  weighIns: WeighIn[];
}

export const WeighInList = ({ weighIns }: Props) => {
  return (
    <Segment raised data-testid="weigh-ins">
      <Item.Group divided>
        {weighIns
          .sort((a, b) => (a.date > b.date ? -1 : 1))
          .map((wi: WeighIn) => (
            <Item key={wi.id} data-testid="weigh-in">
              <Item.Content>
                <Item.Header>{wi.date}</Item.Header>
                <Item.Description>
                  <Statistic.Group size="small">
                    <Statistic data-testid="metric">
                      <Statistic.Value>{wi.weight}</Statistic.Value>
                      <Statistic.Label>pounds</Statistic.Label>
                    </Statistic>
                  </Statistic.Group>
                  <Statistic.Group size="mini" widths="three">
                    <Statistic data-testid="metric">
                      <Statistic.Value>{wi.bmi}</Statistic.Value>
                      <Statistic.Label>BMI</Statistic.Label>
                    </Statistic>
                    <Statistic data-testid="metric">
                      <Statistic.Value>{wi.bodyFatPercent}</Statistic.Value>
                      <Statistic.Label>% body fat</Statistic.Label>
                    </Statistic>
                    <Statistic data-testid="metric">
                      <Statistic.Value>{wi.musclePercent}</Statistic.Value>
                      <Statistic.Label>% muscle</Statistic.Label>
                    </Statistic>
                  </Statistic.Group>
                  <Statistic.Group size="mini" widths="three">
                    <Statistic data-testid="metric">
                      <Statistic.Value>
                        {wi.restingMetabolismCalories}
                      </Statistic.Value>
                      <Statistic.Label>resting metab</Statistic.Label>
                    </Statistic>
                    <Statistic data-testid="metric">
                      <Statistic.Value>{wi.bodyAge}</Statistic.Value>
                      <Statistic.Label>body age</Statistic.Label>
                    </Statistic>
                    <Statistic data-testid="metric">
                      <Statistic.Value>{wi.visceralFat}</Statistic.Value>
                      <Statistic.Label>visceral fat</Statistic.Label>
                    </Statistic>
                  </Statistic.Group>
                </Item.Description>
              </Item.Content>
            </Item>
          ))}
      </Item.Group>
    </Segment>
  );
};
