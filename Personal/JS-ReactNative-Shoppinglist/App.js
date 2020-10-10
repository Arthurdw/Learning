import React, {useState} from 'react';
import {View, StyleSheet, FlatList, Alert} from 'react-native';

import {v4 as uuid} from 'uuid';

import Header from './components/Header';
import LisItem from './components/ListItem';
import AddItem from './components/AddItem';

const App = () => {
  const [items, setItems] = useState([
    {id: uuid(), text: 'Milk'},
    {id: uuid(), text: 'Eggs'},
    {id: uuid(), text: 'Bread'},
    {id: uuid(), text: 'Juice'},
  ]);

  const deleteItem = (id) => {
    setItems((prevItems) => prevItems.filter((item) => item.id != id));
  };

  const addItem = (text) => {
    if (!text) {
      Alert.alert('Oops...', 'Please enter an item', [{text: 'Ok'}]);
    } else {
      setItems((prevItems) => {
        return [{id: uuid(), text}, ...prevItems];
      });
    }
  };

  return (
    <View style={styles.container}>
      <Header title="Shopping List" />
      <FlatList
        data={items}
        renderItem={({item}) => <LisItem item={item} deleteItem={deleteItem} />}
      />
      <AddItem addItem={addItem} />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
});

export default App;
