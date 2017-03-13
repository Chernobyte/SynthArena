var osc = [12];
var env = new Tone.AmplitudeEnvelope();
function setup(){
for(var i = 0; i < 12; i++){
  osc[i] = new Tone.FMOscillator(440, "triangle", "square");
  }
}

osc[0].toMaster().start();
