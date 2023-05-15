import { Box, Button, Heading, Spinner, Text } from '@chakra-ui/react';
import React, { useEffect, useState } from 'react';

export const Home = () => {
  const [manufacturers, setManufacturers] = useState([]);
  const [selectedMan, setSelectedMan] = useState(0);

  const [foods, setFoods] = useState([]);

  function handleButtonClick(manId) {
    setSelectedMan(manId);
    fetch(`${process.env.REACT_APP_BACKEND_URL}/ManufacturerFoods/man/${manId}`)
      .then(res => res.json())
      .then(data => setFoods(data.$values));
  }

  useEffect(() => {
    if (manufacturers.length === 0)
      fetch(`${process.env.REACT_APP_BACKEND_URL}/Manufacturers`)
        .then(response => response.json())
        .then(data => setManufacturers(data.$values));
  }, [manufacturers]);

  if (manufacturers.length === 0) return <Spinner />;

  console.log(foods);

  return (
    <Box>
      <Heading>Home</Heading>
      <Box>
        {manufacturers.map(man => (
          <Button
            colorScheme={selectedMan === man.id ? 'green' : 'blue'}
            onClick={() => handleButtonClick(man.id)}
            key={man.id}
          >
            {man.name}
          </Button>
        ))}
      </Box>
      <Box>
        {foods.map(food => (
          <Text key={food.id}>{food.food.name}</Text>
        ))}
      </Box>
    </Box>
  );
};
