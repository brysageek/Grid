using Microsoft.FluentUI.AspNetCore.Components;

namespace Brysageek.Grid.Web.Services
{
    public class ThemeService
    {
        public event Action? OnThemeChanged;
        
        private DesignThemeModes _currentMode = DesignThemeModes.Dark;
        
        public DesignThemeModes CurrentMode
        {
            get => _currentMode;
            set
            {
                if (_currentMode != value)
                {
                    _currentMode = value;
                    NotifyThemeChanged();
                }
            }
        }

        public bool IsDarkMode => CurrentMode == DesignThemeModes.Dark;

        public void ToggleTheme()
        {
            CurrentMode = CurrentMode == DesignThemeModes.Dark 
                ? DesignThemeModes.Light 
                : DesignThemeModes.Dark;
        }

        private void NotifyThemeChanged()
        {
            OnThemeChanged?.Invoke();
        }
    }
}
