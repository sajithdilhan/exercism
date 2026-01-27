// @ts-check
//
// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Calculates the total bird count.
 *
 * @param {number[]} birdsPerDay
 * @returns {number} total bird count
 */
export function totalBirdCount(birdsPerDay) {
  let totalCount = 0;
  for (let i = 0; i < birdsPerDay.length; i++) {
    totalCount += birdsPerDay[i];
  }
  return totalCount;
}

/**
 * Calculates the total number of birds seen in a specific week.
 *
 * @param {number[]} birdsPerDay
 * @param {number} week
 * @returns {number} birds counted in the given week
 */
export function birdsInWeek(birdsPerDay, week) {
  let iterator = week * 7 -7;
  let max = iterator + 7;
  let totalCount = 0;
  
  for (iterator; iterator < max; iterator++) {
    totalCount += birdsPerDay[iterator];
  }
  return totalCount;
}

/**
 * Fixes the counting mistake by increasing the bird count
 * by one for every second day.
 *
 * @param {number[]} birdsPerDay
 * @returns {void} should not return anything
 */
export function fixBirdCountLog(birdsPerDay) {
  for (let i = 0; i < birdsPerDay.length; i++) {
      let val = birdsPerDay[i];
      birdsPerDay[i] = val +1;
      i++;
  }
  return birdsPerDay;
}
