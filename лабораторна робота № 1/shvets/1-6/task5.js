function daysInMonth(month, year){
	month=(month!=undefined?month:(new Date()).getMonth()+1);
	switch(month){
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			return 31;
		break;
		case 4:
		case 6:
		case 9:
		case 11:
			return 30;
		break;
		case 2:
			if(year<1920){
				var year=year?year:(new
				Date()).getFullYear();
				return 28;
			}else {
				var year = year ? year : (new Date()).getFullYear();
				return (year % 4 == 0) ? 29 : 28;
			}
		break;
	}
}

var d=daysInMonth(2,2016);
console.log(('Кількість днів: '+d));