import React, { useEffect, useState } from 'react';
import { getTrajectory } from '../services/robotService';
import {RobotPosition} from '../../models/RobotPosition';

interface TrajectoryPlayerProps {
    robotId: number;
    startTime: Date;
    endTime: Date;
}

const TrajectoryPlayer: React.FC<TrajectoryPlayerProps> = ({ robotId, startTime, endTime }) => {
    const [trajectory, setTrajectory] = useState<RobotPosition[]>([]);
    const [currentPositionIndex, setCurrentPositionIndex] = useState(0);

    useEffect(() => {
        const fetchData = async () => {
            const data = await getTrajectory(robotId, startTime, endTime);
            setTrajectory(data);
        };
        fetchData();
    }, [robotId, startTime, endTime]);

    useEffect(() => {
        if (trajectory.length > 0) {
            const interval = setInterval(() => {
                setCurrentPositionIndex((prevIndex) => (prevIndex + 1) % trajectory.length);
            }, 500); // Ajuster la vitesse de lecture
            return () => clearInterval(interval);
        }
    }, [trajectory]);

    return (
        <div id="trajectory-player">
            <h3>Robot {robotId} Trajectory</h3>
            {trajectory.length > 0 && (
                <div>
                    <p>Current Position: ({trajectory[currentPositionIndex].x}, {trajectory[currentPositionIndex].y})</p>
                </div>
            )}
        </div>
    );
};

export default TrajectoryPlayer;
