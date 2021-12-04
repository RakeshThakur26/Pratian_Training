enum Status{
    Open,InProgress,Completed
};

function enumFn(){
    let status: Status;
    status = Status.Open;

    return status;
}

console.log(enumFn());