//
// This is only a SKELETON file for the 'Line Up' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const format = (name, number) => {
  let numStr = number.toString();
  let lastDigit = numStr[numStr.length - 1];

  if(numStr.length > 1)
  {
    let last2Digits = String(number).slice(-2);

    if(last2Digits >10 && last2Digits <20)
     lastDigit = 4;
  }

let word;

switch (lastDigit) {
  case '1':
    word = "st";
    break;
  case '2':
    word = "nd";
    break;
  case '3':
    word = "rd";
    break;
  default:
    word = "th";
}

  return name+", you are the "+ number+ word + " customer we serve today. Thank you!";
};
