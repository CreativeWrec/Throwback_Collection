"use strict"
/*
Build all of your functions for displaying and gathering information below (GUI).
*/

// app is the function called to start the entire application
function app(people){
  let searchType = promptFor("Do you know the name of the person you are looking for? Enter 'yes' or 'no'", yesNo).toLowerCase();
  let searchResults;
  switch(searchType){
    case 'yes':
      searchResults = searchByName(people);
      break;
    case 'no':
      // TODO: search by traits
      searchResults = searchByTraits(people);
      break;
      default:people;
    app(people); // restart app
      break;
  }
  
  // Call the mainMenu function ONLY after you find the SINGLE person you are looking for
  mainMenu(searchResults, people);
}



// Menu function to call once you find who you are looking for
function mainMenu(person, people){

  /* Here we pass in the entire person object that we found in our search, as well as the entire original dataset of people. We need people in order to find descendants and other information that the user may want. */

  if(!person){
    alert("Could not find that individual.");
    return app(people); // restart
  }

  let displayOption = prompt("Found " + person[0].firstName + " " + person[0].lastName + " . Do you want to know their 'info', 'family', or 'descendants'? Type the option you want or 'restart' or 'quit'");

  switch(displayOption){
    case "info":
    displayPerson(person);
    // TODO: get person's info
    break;
    case "family":
    displayFamily(person)
    // TODO: get person's family
    break;
    case "descendants":
    displayDescendants(person)
    // TODO: get person's descendants
    break;
    case "restart":
    app(people); // restart
    break;
    case "quit":
    return; // stop execution
    default:
    return mainMenu(person, people); // ask again
  }
}

function searchByName(people){
  let firstName = promptFor("What is the person's first name?", chars);
  let lastName = promptFor("What is the person's last name?", chars);

  let foundPerson = people.filter(function(person){
    if(person.firstName === firstName && person.lastName === lastName){
      return true;
    }
    else{
      return false;
    }
  })
  // TODO: find the person using the name they entered
  return foundPerson;
}

function searchByTraits(people) {
let searchType = promptFor("What trait would you like to search by? 'gender', dob, height, 'weight', 'eyeColor', 'occupation").toLowerCase();
let filterPeople = [];

switch(userSearchChoices){
    case "gender":
    filterPeople = searchByGender(people);
    break;
    case "dob":
    filterPeople = searchByDob(people);
    break;
    case "height":
    filterPeople = searchByHeight(people);
    break;
    case "weight":
    filterPeople = searchByWeight(people);
    break;
    case "eyeColor":
    filterPeople = searchByEyeColor(people);
    break;
    case "occupation":
    filterPeople = searchByOccupation(people);
    break;
    case "restart":
    app(people); 
    break;
  
    default:
      alert("Please Enter A Correct Entry Option");
      searchByTraits(people);
      break;
  }

  if (filterPeople.length > 1) {
    displayPeople(filterPeople);
    searchByTraits(filterPeople);
  } else if (filterPeople.length === 1) {
    let foundPerson = filterPeople[0];
    mainMenu(foundPerson, people);
  } else {
    app(data);
  }
}



// alerts a list of people
function displayPeople(people){
  alert(people.map(function(person){
    return person.firstName + " " + person.lastName;
  }).join("\n"));
}


function searchByGender(people) {
  let userInputGender = prompt("?");

  let newArray = people.filter(function (el) {
    if(el.gender == userInputGender) {
      return true;
    }

  });
  if (newArray === undefined || newArray.length === 0) {
    alert("Could not find said individual.");
    return app(data); 
  }
  return newArray;
}

function searchByDob(people) {
  let userInputDob = prompt("What is the person's Date Of Birth?");

  let newArray = people.filter(function (el) {
    if(el.dob == userInputDob) {
      return true;
    }
  });
  if (newArray === undefined || newArray.length === 0) {
    alert("Could not find said individual.");
    return app(data);
  }
  return newArray;
}

function searchByHeight(people) {
  let userInputHeight = prompt("What is the person's Height?").toLowerCase();

  let newArray = people.filter(function (el) {
    if(el.height == userInputHeight) {
      return true;
    }
  });
  if (newArray === undefined || newArray.length === 0) {
    alert("Could not find said individual.");
    return app(data); 
  }
  return newArray;
}

function searchByWeight(people) {
  let userInputWeight = prompt("What is the person's Weight?").toLowerCase();

  let newArray = people.filter(function (el) {
    if(el.weight == userInputWeight) {
      return true;
    }
  });
  if (newArray === undefined || newArray.length === 0) {
    alert("Could not find said individual.");
    return app(data); 
  }
  return newArray;
}

function searchByEyeColor(people) {
  let userInputEyeColor = prompt("What is the person's Eye Color?");

  let newArray = people.filter(function (el) {
    if(el.eyeColor == userInputEyeColor) {
      return true;
    }
  });
  if (newArray === undefined || newArray.length === 0) {
    alert("Could not find said individual.");
    return app(data);
  }
  return newArray;
}

function searchByOccupation(people) {
  let userInputOccupation = prompt("What is this person's occupation?").toLowerCase();

  let newArray = people.filter(function (el) {
    if(el.occupation == userInputOccupation) {
      return true;
    }
  });
  if (newArray === undefined || newArray.length === 0) {
    alert("Could not find said individual.");
    return app(data); 
  }
  return newArray;
}

function displayPerson(person){
  // print all of the information about a person:
  // height, weight, age, name, occupation, eye color.
  let personInfo = "First Name: " + person[0].firstName + "\n";
  personInfo += "Last Name: " + person[0].lastName + "\n";
  // TODO: finish getting the rest of the information to display
  personInfo += "Gender: " + person[0].gender + "\n";
  personInfo += "Dob: " + person[0].dob + "\n";
  personInfo += "Height: " + person[0].height + "\n";
  personInfo += "Weight: " + person[0].weight + "\n";
  personInfo += "EyeColor: " + person[0].eyeColor + "\n";
  personInfo += "Occupation: " + person[0].occupation + "\n";
  alert(personInfo);
}

// function that prompts and validates user input
function promptFor(question, valid){
  do{
    var response = prompt(question).trim();
  } while(!response || !valid(response));
  return response;
}

function searchByGender (people){
  let userInputGender = prompt ("What is the person's Gender?");
  
  let newArray = people.filter(function (el) {
    if (el.gender == userInputGender) {
      return true;
    }
  }); 

// helper function to pass into promptFor to validate yes/no answers
function yesNo(input){
  return input.toLowerCase() == "yes" || input.toLowerCase() == "no";
}

// helper function to pass in as default promptFor validation
function chars(input){
  return true; // default validation only
}