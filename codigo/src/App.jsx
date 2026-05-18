import React from 'react';
import { LayoutDashboard, History, Bell, Settings, Thermometer, Droplets, AlertTriangle, CheckCircle2, Clock } from 'lucide-react';
import { LineChart, Line, ResponsiveContainer, Tooltip, XAxis } from 'recharts';

const data = [
  { time: '04:00', temp: 18 },
  { time: '08:00', temp: 18 },
  { time: '10:00', temp: 24 },
  { time: '12:00', temp: 22 },
];

export default function App() {
  return (
    <div className="flex min-h-screen bg-slate-100 font-sans text-slate-800">
      <aside className="w-64 bg-slate-900 text-slate-300 flex flex-col p-5">
        <div className="mb-10 text-xs font-bold uppercase tracking-widest text-white border-b border-slate-800 pb-4">Monitoramento</div>
        <nav className="flex-1 space-y-2">
          <div className="bg-blue-600 text-white p-3 rounded-md flex items-center gap-3 cursor-pointer"><LayoutDashboard size={18} /><span>Dashboard</span></div>
          <div className="p-3 hover:bg-slate-800 rounded-md flex items-center gap-3 cursor-pointer"><History size={18} /><span>Histórico</span></div>
          <div className="p-3 hover:bg-slate-800 rounded-md flex items-center gap-3 cursor-pointer"><Bell size={18} /><span>Alertas</span></div>
        </nav>
        <div className="mt-auto pt-4 border-t border-slate-800 text-xs text-white/50">Adm. João - v1.0</div>
      </aside>
      <main className="flex-1 p-8">
        <header className="flex justify-between mb-8"><h1 className="text-2xl font-bold">Dashboard</h1><div className="text-xs">Adm. João 🔔</div></header>
        <div className="grid grid-cols-4 gap-4 mb-8">
          <div className="bg-blue-600 p-4 rounded-xl text-white shadow-lg"><p className="text-[10px] uppercase font-bold opacity-70">Sensores Ativos</p><p className="text-3xl font-bold">14</p></div>
          <div className="bg-orange-500 p-4 rounded-xl text-white shadow-lg"><p className="text-[10px] uppercase font-bold opacity-70">Em Alerta</p><p className="text-3xl font-bold">2</p></div>
          <div className="bg-red-500 p-4 rounded-xl text-white shadow-lg"><p className="text-[10px] uppercase font-bold opacity-70">Offline</p><p className="text-3xl font-bold">1</p></div>
          <div className="bg-slate-200 rounded-xl flex items-center justify-center text-slate-400 italic text-xs">Atualizado agora</div>
        </div>
        <div className="grid grid-cols-3 gap-6">
          <div className="bg-white p-4 rounded-xl shadow-sm border border-gray-100">
            <h3 className="text-xs font-bold text-gray-400 mb-3">CPD 01</h3>
            <div className="bg-blue-500 rounded-lg p-6 text-white flex justify-between items-center">
              <div><span className="text-4xl font-bold">24°C</span><p className="text-[10px] mt-2 opacity-80 italic">Sensor 10:23:24</p></div>
              <div className="bg-white/20 px-4 py-2 rounded-full font-bold">52%</div>
            </div>
          </div>
          <div className="bg-white p-4 rounded-xl shadow-sm border border-gray-100">
            <h3 className="text-xs font-bold text-gray-400 mb-3">CPD 02</h3>
            <div className="bg-orange-400 rounded-lg p-6 text-white flex justify-between items-center relative">
              <span className="absolute top-2 right-2 bg-white/20 px-2 py-1 rounded text-[10px]">Alerta</span>
              <div><span className="text-4xl font-bold">29°C</span><p className="text-[10px] mt-2 opacity-80 italic">Sensor 10:23:03</p></div>
            </div>
          </div>
          <div className="bg-white p-4 rounded-xl shadow-sm border border-gray-100 h-32">
            <ResponsiveContainer width="100%" height="100%">
              <LineChart data={data}><Line type="monotone" dataKey="temp" stroke="#3b82f6" strokeWidth={2} dot={false} /></LineChart>
            </ResponsiveContainer>
          </div>
        </div>
      </main>
    </div>
  );
}