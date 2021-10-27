const Port = require('./Port.js')

class Pier {//пристань
  constructor (options) {
    this.id = options.id
    this.name = options.name
    this.Port = options.Port
  }
}

module.exports = Pier