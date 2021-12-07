var mongoose=require('mongoose');
mongoose.Promise = global.Promise;
mongoose.connect('mongodb+srv://admin3:uran@cluster0.wcywy.mongodb.net/lab6?retryWrites=true&w=majority', { useNewUrlParser: true }) ;
mongoose.set('useFindAndModify', false);
console.log("mongodb connect...")
module.exports=mongoose;
