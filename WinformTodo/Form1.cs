namespace WinformTodo
{
    public partial class Form1 : Form
    {
        private List<Todo> TaskList { get; set; }

        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void submitForm(object sender, EventArgs e)
        {

            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Task line is empty, please provide a task description.");
                return;
            }

            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Task description needs to be provided.");
                return;
            }

            if (Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("Please provide the due date for your task.");
                return;
            }

            if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorrectly formatted,please resubmit.");
                return;
            }

            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));
            TaskList.Add(myTodo);
            fpTasks.Controls.Add(new TaskControl(myTodo));
            
            UpdateListBox();
            ClearForm();
        }
        
        public void UpdateListBox()
        {
            //lbTaskList.Items.Clear();

            var list = TaskList
                .Where(t => t.IsDone == false)
                .OrderBy(t => t.DueDate)
                .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                //lbTaskList.Items.Add(list[i].ToString());
            }
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form Cleared");
        }

        public void ClearForm()
        {
            txtTaskDescription.Clear();
            txtDueDate.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submitForm(sender, e);
            }
        }

        //private void lbTaskList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //MessageBox.Show($"Selected Index is: {lbTaskList.SelectedIndex}");
        //    //int selectedIndex = lbTaskList.SelectedIndex;
        //    //string? selectedItem = lbTaskList.SelectedItem as String;

        //    if (selectedIndex == -1)
        //    {
        //        return;
        //    }

        //    if (selectedItem == null) 
        //    {
        //        MessageBox.Show("No item selected at the index.");
        //        return; 
        //    }

        //    int id = Int32.Parse(selectedItem.Split(" - ")[0]);

        //    var todo = TaskList.Find(t => t.Id == id);

        //    if (todo != null)
        //    {
        //        todo.IsDone = !todo.IsDone;

        //        UpdateListBox();
        //    }

        //}
    }
}