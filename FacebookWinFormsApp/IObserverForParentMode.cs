using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public interface IObserverForParentMode
    {
        void Update(bool i_ParentModeStatus);
    }

    public class TextBoxObserver : IObserverForParentMode
    {
        private TextBox m_TextBox;
        public TextBoxObserver(TextBox i_TextBox)
        {
            m_TextBox = i_TextBox;
        }
        public void Update(bool i_ParentModeStatus)
        {
            if (m_TextBox != null)
            {
                if (i_ParentModeStatus)
                {
                    m_TextBox.Visible = false;
                }
                else
                {
                    m_TextBox.Visible = true;
                }
            }
        }
    }

    public class PictureBoxObserver : IObserverForParentMode
    {
        private PictureBox m_PictureBox;
        public PictureBoxObserver(PictureBox i_PictureBox)
        {
            m_PictureBox = i_PictureBox;
        }
        public void Update(bool i_ParentModeStatus)
        {
            if (m_PictureBox != null)
            {
                if (i_ParentModeStatus)
                {
                    m_PictureBox.Visible = false;
                }
                else
                {
                    m_PictureBox.Visible = true;
                }
            }
        }
    }

    public class ButtonObserver : IObserverForParentMode
    {
        private Button m_Button;
        public ButtonObserver(Button i_Button)
        {
            m_Button = i_Button;
        }
        public void Update(bool i_ParentModeStatus)
        {
            if (m_Button != null)
            {
                if (i_ParentModeStatus)
                {
                    m_Button.Enabled = false;
                }
                else
                {
                    m_Button.Enabled = true;
                }
            }
        }
    }

    public class PanelObserver : IObserverForParentMode
    {
        private Panel m_Panel;
        public PanelObserver(Panel i_Panel)
        {
            m_Panel = i_Panel;
        }
        public void Update(bool i_ParentModeStatus)
        {
            if (m_Panel != null)
            {
                if (i_ParentModeStatus)
                {
                    m_Panel.Enabled = false;
                }
                else
                {
                    m_Panel.Enabled = true;
                }
            }
        }
    }

    public class ChartObserver : IObserverForParentMode
    {
        private Chart m_Chart;
        public ChartObserver(Chart i_Chart)
        {
            m_Chart = i_Chart;
        }
        public void Update(bool i_ParentModeStatus)
        {
            if (m_Chart != null)
            {
                if (i_ParentModeStatus)
                {
                    m_Chart.Visible = false;
                }
                else
                {
                    m_Chart.Visible = true;
                }
            }
        }
    }

    public class LabelObserver : IObserverForParentMode
    {
        private Label m_Label;
        public LabelObserver(Label i_Label)
        {
            m_Label = i_Label;
        }
        public void Update(bool i_ParentModeStatus)
        {
            if (m_Label != null)
            {
                if (i_ParentModeStatus)
                {
                    m_Label.Visible = false;
                }
                else
                {
                    m_Label.Visible = true;
                }
            }
        }
    }
}
