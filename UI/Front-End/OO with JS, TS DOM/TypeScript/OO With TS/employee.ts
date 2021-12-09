export class Employee {
    name: string;
    title: string;

    getEName(): string {
        return this.name;
    }
    setEName(_name: string) {
        this.name = _name;
    }

    getTitle(): string {
        return this.title;
    }
    setTitle(_title: string) {
        this.title = _title;
    }


}