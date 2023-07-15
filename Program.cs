// Get a list of MadLibs
List<MadLib> madLibs = MadLibData.MadLibs;

string index = args[0];

int madLibIndex;
if (string.IsNullOrEmpty(index)) {
    madLibIndex = 0;
    // Pick a random MadLib from the list
} else {
    madLibIndex = Convert.ToInt32(index);
}


ProgramUI ui = new ProgramUI();
// Given the number, pick a MadLib
ui.DoMadLib(madLibs[madLibIndex]);

// TODO: Ask the user if they'd like to do another one
//     keep looping until they say no