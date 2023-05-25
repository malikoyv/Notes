using System.Data;

namespace Notes
{
    public partial class Notes : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not a valid note"); }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            titleNote.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            noteBox.Text = "";
            titleNote.Text = "";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing == true)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleNote.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleNote.Text, noteBox.Text);
            }

            titleNote.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void previousNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            titleNote.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void color_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int r = random.Next(100, 255);
            int g = random.Next(100, 255);
            int b = random.Next(100, 255);

            BackColor = Color.FromArgb(r, g, b);
            color.BackColor = Color.FromArgb(r, g, b);
            newButton.BackColor = Color.FromArgb(r, g, b);
        }
    }
}