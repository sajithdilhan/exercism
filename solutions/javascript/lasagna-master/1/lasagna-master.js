/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */

export function cookingStatus(remainingTime) {
  switch(remainingTime){
    case 0:
      return 'Lasagna is done.';
    case undefined:
      return 'You forgot to set the timer.';
    default:
      return 'Not done, please wait.';
  }
}

export function addSecretIngredient(friendsList, myList){

  let friendItem = friendsList[friendsList.length-1];
  myList.push(friendItem);
 
}

export function preparationTime(layers, avgTime = 2){
   return layers.length * avgTime;
}

export function quantities(layers){

  let noodlesCount = 0;
  let sauceCount = 0;
  for(let i = 0; i < layers.length; i++)
    {
       if(layers[i] == 'sauce')
         sauceCount++;
       if(layers[i] == 'noodles')
         noodlesCount++;
    }

  const quantity = {
    noodles: noodlesCount*50, sauce: sauceCount*0.2
  };

  return quantity;
}

export function scaleRecipe(recipe, portions){
  let copyObj = { ...recipe };
 Object.keys(copyObj).forEach(key => {
    const value = copyObj[key]/2*portions;
    copyObj[key] = value;
});

  return copyObj;
}