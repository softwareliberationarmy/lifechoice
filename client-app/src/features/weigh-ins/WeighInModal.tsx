import { Button, Form, Modal } from 'semantic-ui-react';
import { WeighIn } from '../../app/model/WeighIn';
import { ChangeEvent, useEffect, useState } from 'react';
import { useStore } from '../../app/store/store';
import { observer } from 'mobx-react-lite';

const WeighInModal = () => {
  const { weighInStore } = useStore();
  const { createMode, setCreateMode, addWeighIn } = weighInStore;

  function newWeighIn(): WeighIn {
    return {
      id: 0,
      date: '',
      weight: 0,
      bmi: 0,
      bodyFatPercent: 0,
      musclePercent: 0,
      restingMetabolismCalories: 0,
      bodyAge: 0,
      visceralFat: 0,
    };
  }

  const [weighIn, setWeighIn] = useState<WeighIn>(newWeighIn());

  //re-initialize the weigh-in every time the open prop changes
  useEffect(() => {
    setWeighIn(newWeighIn());
  }, [createMode]);

  function handleNumericInputChange(event: ChangeEvent<HTMLInputElement>) {
    const { name, value } = event.target;
    setWeighIn({ ...weighIn, [name]: +value });
  }

  function handleInputChange(event: ChangeEvent<HTMLInputElement>) {
    const { name, value } = event.target;
    setWeighIn({ ...weighIn, [name]: value });
  }

  return (
    <Modal data-testid="weigh-in-modal" open={createMode}>
      <Modal.Header>New Weigh In</Modal.Header>
      <Modal.Content>
        <Form as="form">
          <Form.Input
            label="Date"
            value={weighIn.date}
            placeholder="Date"
            onChange={handleInputChange}
            name="date"
          />
          <Form.Input
            label="Weight"
            value={weighIn.weight}
            placeholder="Weight"
            name="weight"
            onChange={handleNumericInputChange}
            type="number"
          />
          <Form.Input
            label="BMI"
            value={weighIn.bmi}
            placeholder="BMI"
            name="bmi"
            onChange={handleNumericInputChange}
            type="number"
          />
          <Form.Input
            label="Body Fat %"
            value={weighIn.bodyFatPercent}
            placeholder="BodyFat"
            name="bodyFatPercent"
            onChange={handleNumericInputChange}
            type="number"
          />
          <Form.Input
            label="Muscle %"
            value={weighIn.musclePercent}
            placeholder="Muscle"
            name="musclePercent"
            onChange={handleNumericInputChange}
            type="number"
          />
          <Form.Input
            label="Resting Metabolism"
            value={weighIn.restingMetabolismCalories}
            placeholder="RestingMetab"
            name="restingMetabolismCalories"
            onChange={handleNumericInputChange}
            type="number"
          />
          <Form.Input
            label="Body Age"
            value={weighIn.bodyAge}
            placeholder="BodyAge"
            name="bodyAge"
            onChange={handleNumericInputChange}
            type="number"
          />
          <Form.Input
            label="Visceral Fat"
            value={weighIn.visceralFat}
            placeholder="VisceralFat"
            name="visceralFat"
            onChange={handleNumericInputChange}
            type="number"
          />
        </Form>
      </Modal.Content>
      <Modal.Actions>
        <Button color="black" onClick={() => setCreateMode(false)}>
          Cancel
        </Button>
        <Button positive onClick={() => addWeighIn(weighIn)}>
          Submit
        </Button>
      </Modal.Actions>
    </Modal>
  );
};

export default observer(WeighInModal);
