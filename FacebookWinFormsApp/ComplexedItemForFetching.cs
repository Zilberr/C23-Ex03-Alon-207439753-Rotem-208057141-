using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ComplexedItemForFetching
    {
        public Point ButtonLocation { get; set; }
        public Button Button { get; set; }
        public ListBox ListBox { get; set; }
        public ListBox SecondaryListBox { get; set; }
        public PictureBox Image { get; set; }
        public Label Label { get; set; }
        private ComplexedItemForFetching() { }
        
        public class Builder
        {
            private ComplexedItemForFetching m_ComplexedItem = new ComplexedItemForFetching();
            public Builder(Point i_ButtonLocation)
            {
                m_ComplexedItem.ButtonLocation = i_ButtonLocation;
            }
            public Builder AddButton(string i_ButtonText, EventHandler i_ClickHandler)
            {
                m_ComplexedItem.Button = new Button();
                m_ComplexedItem.Button.Location = m_ComplexedItem.ButtonLocation;
                m_ComplexedItem.Button.BackColor = SystemColors.Menu;
                m_ComplexedItem.Button.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
                m_ComplexedItem.Button.Size = new Size(230, 45);
                m_ComplexedItem.Button.UseVisualStyleBackColor = false;
                m_ComplexedItem.Button.Text = i_ButtonText;
                m_ComplexedItem.Button.Click += i_ClickHandler;

                return this;
            }
            public Builder AddListBoxWithEvent(EventHandler i_ClickHandler)
            {
                Point listBoxLocation = new Point();
                listBoxLocation.X = m_ComplexedItem.ButtonLocation.X;
                listBoxLocation.Y = m_ComplexedItem.ButtonLocation.Y - 230;

                m_ComplexedItem.ListBox = new ListBox();
                m_ComplexedItem.ListBox.Location = listBoxLocation;
                m_ComplexedItem.ListBox.DisplayMember = "Name";
                m_ComplexedItem.ListBox.Font = new Font("Miriam", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (byte)(0));
                m_ComplexedItem.ListBox.FormattingEnabled = true;
                m_ComplexedItem.ListBox.HorizontalScrollbar = true;
                m_ComplexedItem.ListBox.ItemHeight = 17;
                m_ComplexedItem.ListBox.Size = new Size(230, 225);
                m_ComplexedItem.ListBox.SelectedIndexChanged += i_ClickHandler;

                return this;
            }
            public Builder AddListBox()
            {
                Point listBoxLocation = new Point();
                listBoxLocation.X = m_ComplexedItem.ButtonLocation.X;
                listBoxLocation.Y = m_ComplexedItem.ButtonLocation.Y - 230;

                m_ComplexedItem.ListBox = new ListBox();
                m_ComplexedItem.ListBox.Location = listBoxLocation;
                m_ComplexedItem.ListBox.Font = new Font("Miriam", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (byte)(0));
                m_ComplexedItem.ListBox.FormattingEnabled = true;
                m_ComplexedItem.ListBox.HorizontalScrollbar = true;
                m_ComplexedItem.ListBox.ItemHeight = 17;
                m_ComplexedItem.ListBox.Size = new Size(230, 225);

                return this;
            }
            public Builder AddSecondaryListBox()
            {
                Point listBoxLocation = new Point();
                listBoxLocation.X = m_ComplexedItem.ButtonLocation.X - 155;
                listBoxLocation.Y = m_ComplexedItem.ButtonLocation.Y - 230;

                m_ComplexedItem.SecondaryListBox = new ListBox();
                m_ComplexedItem.SecondaryListBox.Location = listBoxLocation;
                m_ComplexedItem.SecondaryListBox.DisplayMember = "Name";
                m_ComplexedItem.SecondaryListBox.Font = new Font("Miriam", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (byte)(0));
                m_ComplexedItem.SecondaryListBox.FormattingEnabled = true;
                m_ComplexedItem.SecondaryListBox.HorizontalScrollbar = true;
                m_ComplexedItem.SecondaryListBox.ItemHeight = 17;
                m_ComplexedItem.SecondaryListBox.Size = new Size(150, 160);

                return this;
            }
            public Builder AddImage()
            {
                Point imageLocation = new Point();
                imageLocation.X = m_ComplexedItem.ButtonLocation.X + 237;
                imageLocation.Y = m_ComplexedItem.ButtonLocation.Y - 230;

                m_ComplexedItem.Image = new PictureBox();
                m_ComplexedItem.Image.Location = imageLocation;
                m_ComplexedItem.Image.Size = new Size(165, 185);
                m_ComplexedItem.Image.SizeMode = PictureBoxSizeMode.StretchImage;
                m_ComplexedItem.Image.TabIndex = 5;
                m_ComplexedItem.Image.TabStop = false;

                return this;
            }
            public Builder AddLabel(string i_LabelText)
            {
                m_ComplexedItem.Label = new Label();
                m_ComplexedItem.Label.AutoSize = true;
                m_ComplexedItem.Label.Visible = false;
                m_ComplexedItem.Label.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, (byte)(0));
                m_ComplexedItem.Label.Margin = new Padding(4, 0, 4, 0);
                m_ComplexedItem.Label.TabIndex = 13;
                m_ComplexedItem.Label.Text = i_LabelText;

                Point labelLocation = new Point();
                labelLocation.X = m_ComplexedItem.ButtonLocation.X;
                labelLocation.Y = m_ComplexedItem.ButtonLocation.Y + 50;
                m_ComplexedItem.Label.Location = labelLocation;

                return this;
            }
            public Builder AddSecondaryPanel(Panel i_PannelToAdd)
            {
                Point panelLocation = new Point();
                panelLocation.X = m_ComplexedItem.ButtonLocation.X - 215;
                panelLocation.Y = m_ComplexedItem.ButtonLocation.Y - 230;
                i_PannelToAdd.Location = panelLocation;

                return this;
            }
            public ComplexedItemForFetching Build()
            {
                return m_ComplexedItem;
            }
        }
    }
}