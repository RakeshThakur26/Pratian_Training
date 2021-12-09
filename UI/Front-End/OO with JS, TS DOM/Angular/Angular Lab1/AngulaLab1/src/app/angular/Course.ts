export class Course{
    name:string;
    topicName:string[] = [];
    duration:number;
    startDate:string;
    endDate:string;

    constructor(_name:string, _duration:number, _startDate:string, _endDate:string){
        this.duration = _duration;
        this.endDate = _endDate;
        this.name = _name;
        this.startDate = _startDate;
    }

}