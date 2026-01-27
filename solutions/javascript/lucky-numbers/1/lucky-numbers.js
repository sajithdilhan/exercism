// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
export function twoSum(array1, array2) {
  let ar1 = array1.join("");
  let ar2 = array2.join("");

  return Number(ar1) + Number(ar2);
}

/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean} whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  let i=0;
  let str = String(value);
  let j= str.length -1;
  let result = true;
  while(i < j)
    {
      if(str[i] != str[j])
      {
        result = false;
        break;
      }
      i++;
      j--;
    }
  return result;
}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {
  console.log(input);
  if(input == null || input === '' )
     return 'Required field';
  else if(Number.isNaN(Number(input)) || Number(input) ===0)
      return 'Must be a number besides 0';
  else
      return '';
}
