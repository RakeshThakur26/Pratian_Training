export class Democlass{
    id:number;
    topic:string;
    status:string;

    constructor(_topic:string, _id:number, _status:string){
        this.id = _id;
        this.status = _status;
        this.topic = _topic;
    }
    showTopic(){
        console.log(`${this.topic} has status: ${this.status}`);
    }
}