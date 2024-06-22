﻿using Command.HeadFirst.Commands;
using System.Text;

namespace Command.HeadFirst.Invokers
{
    public class RemoteControlWithUndo
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControlWithUndo()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            _undoCommand = noCommand;

            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append("\n------ Remote Control-------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append($"[slot{i}] {_onCommands[i].GetType().Name} {_offCommands[i].GetType().Name}\n");
            }
            stringBuilder.Append($"[undo] {_undoCommand.GetType().Name}");
            return stringBuilder.ToString();
        }
    }
}
