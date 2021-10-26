const Pier = require('./Pier.js')
const Ship = require('./Ship.js')

class ShipOnPier {
  constructor (options) {
    this.Pier = options.Pier // name of pier 
    this.Ship = options.Ship
  }
}

module.exports = ShipOnPier