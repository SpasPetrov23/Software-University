function timeToWalk (totalSteps, strideLength, speed){
    let distance = totalSteps * strideLength;
    let breaksCount = Math.floor(distance / 500);
    let speedInMeters = speed / 3.6;
    let time = distance / speedInMeters;

    let hours = Math.floor(time / 60 / 60).toFixed(0);
    hours = String((hours < 10 ? '0' + hours : hours))
    let minutes = Math.floor(time / 60 % 60);
    minutes += breaksCount;
    minutes = String((minutes < 10 ? '0' + minutes : minutes))
    let seconds = (time % 60).toFixed(0);

    let result = `${hours}:${minutes}:${seconds}`;

    console.log(result);
}

timeToWalk(4000, 0.60, 5);
timeToWalk(2564, 0.70, 5.5);