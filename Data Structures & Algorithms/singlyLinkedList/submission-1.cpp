class LinkedList {
struct Node
{
        Node *next = nullptr;
        int val;
};
    Node* head = nullptr;
public:
    LinkedList() = default;

    int get(int index) {
        if (index < 0) 
        {
            return -1;
        }

        Node* current = head;
        for (int i = 0; i < index && current != nullptr; ++i) 
        {
            current = current->next;
        }

        if (current == nullptr) 
        {
            return -1;
        }

        return current->val;
    }

    void insertHead(int val) {
        Node* newNode = new Node;
        newNode->val = val;
        newNode->next = head;
        head = newNode;
    }
    
    void insertTail(int val) {
        Node* newNode = new Node;
        newNode->val = val;
        newNode->next = nullptr;

        if(head == nullptr)
        {
            head = newNode;
            return;
        }
        Node* current = head;
        while(current->next != nullptr)
        {
            current = current->next;
        }
        current->next = newNode;
    }

    bool remove(int index) {
        if (index < 0) 
        {
            return false;
        }

        Node* current = head;
        Node* tmp = head;

        for (int i = 0; i < index - 1 && tmp != nullptr; ++i) 
        {
            tmp = tmp->next;
        }

        for (int i = 0; i < index && current != nullptr; ++i) 
        {
            current = current->next;
        }
        if (current == nullptr) {
            return false;
        }

        if (index == 0) {
            head = current->next;
        } else {
            tmp->next = current->next;
        }

        delete current;
        return true;
    }

    vector<int> getValues() {
        Node* current = head;
        vector<int> result;

        while(current != nullptr)
        {
            result.push_back(current->val);
            current = current->next;
        }
        return result;
    }
};