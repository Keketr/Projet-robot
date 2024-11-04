import axios from 'axios';
import {RobotPosition} from '../../models/RobotPosition';
import {HeatmapData} from '../../models/HeatmapData';

const apiUrl = 'https://localhost:5001/api/robots';

export const getTrajectory = async (robotId: number, startTime: Date, endTime: Date): Promise<RobotPosition[]> => {
    const response = await axios.get<RobotPosition[]>(`${apiUrl}/${robotId}/trajectory`, {
        params: { startTime: startTime.toISOString(), endTime: endTime.toISOString() },
    });
    return response.data;
};

export const getHeatmapData = async (startTime: Date, endTime: Date): Promise<HeatmapData[]> => {
    const response = await axios.get<HeatmapData[]>(`${apiUrl}/heatmap`, {
        params: { startTime: startTime.toISOString(), endTime: endTime.toISOString() },
    });
    return response.data;
};


