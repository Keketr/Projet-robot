import React, { useEffect, useState } from 'react';
import { getHeatmapData } from '../services/robotService';
import {HeatmapData} from '../../models/HeatmapData';

const HeatmapComponent: React.FC = () => {
    const [heatmapData, setHeatmapData] = useState<HeatmapData[]>([]);

    useEffect(() => {
        const fetchData = async () => {
            const data = await getHeatmapData(new Date(), new Date());
            setHeatmapData(data);
        };
        fetchData();
    }, []);

    const renderHeatmap = () => {
        // Utiliser une bibliothèque comme D3.js ou Leaflet pour afficher la heatmap avec les données
    };

    useEffect(() => {
        renderHeatmap();
    }, [heatmapData]);

    return <div id="heatmap">Heatmap will be displayed here</div>;
};

export default HeatmapComponent;
